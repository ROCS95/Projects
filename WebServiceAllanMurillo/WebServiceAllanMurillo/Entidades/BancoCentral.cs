using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceAllanMurillo.Entidades
{
    public class BancoCentral
    {

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Datos_de_INGC011_CAT_INDICADORECONOMIC
    {

        private Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC iNGC011_CAT_INDICADORECONOMICField;

        /// <remarks/>
        public Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC INGC011_CAT_INDICADORECONOMIC
        {
            get
            {
                return this.iNGC011_CAT_INDICADORECONOMICField;
            }
            set
            {
                this.iNGC011_CAT_INDICADORECONOMICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC
    {

        private ushort cOD_INDICADORINTERNOField;

        private System.DateTime dES_FECHAField;

        private decimal nUM_VALORField;

        /// <remarks/>
        public ushort COD_INDICADORINTERNO
        {
            get
            {
                return this.cOD_INDICADORINTERNOField;
            }
            set
            {
                this.cOD_INDICADORINTERNOField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DES_FECHA
        {
            get
            {
                return this.dES_FECHAField;
            }
            set
            {
                this.dES_FECHAField = value;
            }
        }

        /// <remarks/>
        public decimal NUM_VALOR
        {
            get
            {
                return this.nUM_VALORField;
            }
            set
            {
                this.nUM_VALORField = value;
            }
        }
    }
}
