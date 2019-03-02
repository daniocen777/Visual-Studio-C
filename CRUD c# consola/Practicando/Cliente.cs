using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando
{
    class Cliente
    {
        private string IDE_CLI;
        private string NOM_CLI;
        private string PAT_CLI;
        private string MAT_CLI;
        private string FON_CLI;
        private string DNI_CLI;
        private string DIR_CLI;

        public Cliente()
        {

        }

        public string getIDE_CLI()
        {
            return IDE_CLI;
        }

        public void setIDE_CLI(string IDE_CLI)
        {
            this.IDE_CLI = IDE_CLI;
        }

        public string getNOM_CLI()
        {
            return NOM_CLI;
        }

        public void setNOM_CLI(string NOM_CLI)
        {
            this.NOM_CLI = NOM_CLI;
        }

        public string getPAT_CLI()
        {
            return PAT_CLI;
        }

        public void setPAT_CLI(string PAT_CLI)
        {
            this.PAT_CLI = PAT_CLI;
        }

        public string getMAT_CLI()
        {
            return MAT_CLI;
        }

        public void setMAT_CLI(string MAT_CLI)
        {
            this.MAT_CLI = MAT_CLI;
        }

        public string getFON_CLI()
        {
            return FON_CLI;
        }

        public void setFON_CLI(string FON_CLI)
        {
            this.FON_CLI = FON_CLI;
        }

        public string getDNI_CLI()
        {
            return DNI_CLI;
        }

        public void setDNI_CLI(string DNI_CLI)
        {
            this.DNI_CLI = DNI_CLI;
        }

        public string getDIR_CLI()
        {
            return DIR_CLI;
        }

        public void setDIR_CLI(string DIR_CLI)
        {
            this.DIR_CLI = DIR_CLI;
        }

    }
}
