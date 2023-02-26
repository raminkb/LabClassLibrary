using StudentClassLibrary;

namespace LabClassLibrary
{
    public partial class Form1 : Form
    {
        StudentController controller = new StudentController();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.textBoxName.Text;
            string input_student_id = this.textBoxID.Text;
            controller.addStudent2List(input_student_id, input_name);
            displayData();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.openFile();
            displayData();

            //[/]display data totbListstudent
        }
        private void displayData()
        {         //Todo
                  //[ ] fix display data from list*/
            this.textBoxListSudent.Text = controller.displaydata();
           
        }
    }
}