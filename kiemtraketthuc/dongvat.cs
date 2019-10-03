using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace kiemtraketthuc
{
    class dongvat
    {
        public dongvat() { }
        public dongvat(string name)
        {

            this.name = name;

        }

        private string name;
        public string dongvatName
        {
            get { return name; }
            set { name = value; }
        }
        private string maulong;
       

        public virtual void Talk()
        {
            if (dongvatName.Equals("Gâu gâu")) 
                MessageBox.Show(this.dongvatName );
            else if (dongvatName.Equals("Meo meo")) 
                MessageBox.Show(this.dongvatName );
        }
    }
}