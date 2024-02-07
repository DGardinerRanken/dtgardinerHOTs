using System.Numerics;

namespace HOT_03_02
{
    public partial class frmTestScores : Form
    {
        static decimal totalScore = 0m;
        static decimal totalTests = 0m;
        static decimal totalAvg = 0;
        static decimal lowAvg = 0m;
        static decimal highAvg = 0m;
        static decimal avg = 0m;
        const decimal TESTMIN = 0m;
        const decimal TESTMAX = 100m;
        static decimal scoreSum = 0m;

        public frmTestScores()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateAverages();
        }

        private void CalculateAverages() 
        {
            try
            {
                int testScore = Convert.ToInt32(txtEnterTestScore.Text);

                if (testScore > TESTMAX || testScore < TESTMIN)
                {
                    throw new ArgumentOutOfRangeException();
                }

                scoreSum += testScore;
                totalTests++;
                totalAvg = (scoreSum / totalTests);

                //I could not quite figure out how to show the min and max test score values.
                

                lblResult.Text = ($"Number of Scores: {totalTests}\nSum of Test Scores: {scoreSum}\n" +
                                  $"Average Test Score: {totalAvg:n3}\nLowest Test Score: {lowAvg:n3}\n" +
                                  $"Highest Test Score: {highAvg:n3}");
            }
            catch (ArgumentNullException ane)
            {
                ShowErrorMessage("System Message:\t" + ane.Message + "\n\n" +
                                 "You Must Enter A Value for Test Score",
                                 "ARGUMENTNULLEXCEPTION");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message:\t" + aoore.Message + "\n\n" +
                                 "You Must Enter A Value between 0 and 100.",
                                 "ARGUMENTOUTOFRANGEEXCEPTION");
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message + "\n\n" +
                                 "You Must Enter A Valid decimal for Test Score",
                                 "FORMATEXCEPTION");
            }
            txtEnterTestScore.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtEnterTestScore.Text = string.Empty;
            txtEnterTestScore.Focus();
            lblResult.Text = string.Empty;
            totalScore = 0;
            totalAvg = 0;
            totalTests = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }
        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Are You Sure You Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
