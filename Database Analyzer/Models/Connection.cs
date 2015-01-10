using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Analyzer.Models
{
    public class Connection
    {
        #region Fields

        private String m_connectionString;
        private Boolean m_connectionVerified = false;

        #endregion

        #region Constructors

        public Connection()
        {
        }

        public Connection(String ConnectionString)
        {
            m_connectionString = ConnectionString;
        }

        #endregion

        #region Properties

        public String ConnectionString
        {
            get
            {
                return m_connectionString;
            }
            set
            {
                if (m_connectionString != value)
                {
                    m_connectionString = value;
                }
            }
        }

        public Boolean ConnectionVerified
        {
            get
            {
                return m_connectionVerified;
            }
            set
            {
                if (m_connectionVerified != value)
                {
                    m_connectionVerified = value;
                }
            }
        }

        #endregion
    }
}
