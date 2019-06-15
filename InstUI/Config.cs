using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstUI {
    public class Config {
        /// <summary>
        /// The installer type.
        /// </summary>
        public Installer.InstallerTypes instType = Installer.InstallerTypes.Inno;
        /// <summary>
        /// The name of the product.
        /// </summary>
        public string productName = "My Product";
        /// <summary>
        /// The name of the company.
        /// </summary>
        public string companyName = "Company";
        /// <summary>
        /// The color of the installer.
        /// </summary>
        public System.Drawing.Color background = System.Drawing.Color.Teal;
    }
}
