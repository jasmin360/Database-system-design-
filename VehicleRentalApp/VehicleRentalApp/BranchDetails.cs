using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalApp.DAL;
using VehicleRentalApp.Models;

namespace VehicleRentalApp
{
    public partial class BranchDetails : Form
    {
        Branch branchitself = null;
        public BranchDetails(Branch branchitself)
        {
            InitializeComponent();
            this.branchitself = branchitself;
            BranchIdK.Text = $"Branch ID: {this.branchitself.Branch_ID}";
            lbladdressK.Text = $"City: {this.branchitself.City}, Street Number: {this.branchitself.Street_Number}, Building Number: {this.branchitself.Building_Number}";
            lbBranchNumbersK.Text = $"Contact Number : {this.branchitself.Contact_Number}";
        }

        private void BranchDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
