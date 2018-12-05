using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiddleLayer;
using FactoryCustomer;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private CustomerBase cust = null;
        

        private void cmbCustomerType_Click(object sender, EventArgs e)
        {
            cust = Factory.AddCustomer(cmbCustomerType.Text);
        }
        private void SetProperties()
        {
            cust.CustomerName = tbCustomerName.Text;
            cust.PhoneNumber = tbPhoneNumber.Text;
            cust.BillDate = Convert.ToDateTime(tbBillDate.Text);
            cust.BillAmount = Convert.ToDecimal(tbBillAmount.Text);
            cust.Address = tbAddress.Text;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SetProperties();
                cust.Validate();
            }
            catch(Exception ex)
            {
                tbCheckReq.Text = ex.Message.ToString();
            }
        }
    }
}
