using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstUI {
    public class Installer {
        /// <summary>
        /// The types of the installer executable.
        /// </summary>
        public enum InstallerTypes {
            /// <summary>
            /// Nullsoft. Make sure you implement SilentInstall.
            /// </summary>
            Nsis,
            /// <summary>
            /// Inno Setup.
            /// </summary>
            Inno,
            /// <summary>
            /// InstallShield 7+.
            /// </summary>
            InstallShield,
            /// <summary>
            /// InstallShield, using an ISS answer file.
            /// </summary>
            InstallShieldIss,
            /*/// <summary>
            /// Any MSI, will be installed with msiexec.
            /// </summary>
            Msi,*/
            /// <summary>
            /// Ethalone Ghost. Make sure you provide a default installation type.
            /// </summary>
            Ghost/*,
            /// <summary>
            /// Installs to AppData. Currently not implemented.
            /// </summary>
            None*/
        }

        public static Dictionary<InstallerTypes, string> silent = new Dictionary<InstallerTypes, string>() {
            {InstallerTypes.Nsis, "/S /D={Dir}"},
            {InstallerTypes.Inno, "/sp- /silent /norestart"},
            {InstallerTypes.InstallShield, "/s /v\"/qb\""},
            {InstallerTypes.InstallShieldIss, "/s /f1\"{AnswerFile}\"" },
            //{InstallerTypes.Msi, "/qb /i {File}"},
            {InstallerTypes.Ghost, "-s" }/*,
            {InstallerTypes.None, "" }*/
        };
    }
}
