using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4
{
    public partial class Form1 : Form
    {
        //Service service;
        public Form1()
        {
            InitializeComponent();
            Animal a1 = new Animal ( 1,"hipo",'F',10, true, 0, false );
            Service service = new Service();
            service.Health_Animals.Enqueue(a1);
            int idx;
            //add to charts:
            for (idx = 0; idx < service.Health_Animals.GetLastPos(); idx++) 
                lstbxHealthAnimalsChart.Items.Add(service.Sick_Animals.GetSick(idx).GetName());
            for (idx = 0; idx < service.Sick_Animals.GetLastPos(); idx++)
                lstbxHealthAnimalsChart.Items.Add(service.Health_Animals.GetHealth(idx).GetName());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSickChart_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddSickAnimal_Click(object sender, EventArgs e)
        {
            //if(service.Sick_Animals.IsFull())
            {
                //Application.Run();
            }
        }
       
    }
}
