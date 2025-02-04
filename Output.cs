//  Authors:  Caren Dymond, Sarah Beukema
//Routine contains Landfill Gas Management parameters

using Landis.Utilities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Landis.Extension.FPS
{
    /// <summary>
    /// 
    /// </summary>
    public class OutputAmount
    {
        private int m_outTime;
        private int m_pool;
        private int m_loc;
        private double m_amount;

        //---------------------------------------------------------------------
        // Initializes the OutputAmount class
        //
        public OutputAmount(int outTime,
                                int iCode,
                                int iloc,
                               double amt)
        {
            this.m_outTime = outTime;
            this.m_pool = iCode;
            this.m_loc = iloc;
            this.m_amount = amt;

        }
        //---------------------------------------------------------------------
        /// <summary>
        ///year of output
        ///</summary>
        public int outTime
        {
            get { return m_outTime; }
        }
        //---------------------------------------------------------------------
        public int OutPool
        {
            get { return m_pool; }
        }
        public int OutLoc
        {
            get { return m_loc; }
        }

        public double GetOutputAmount()
        {
            return m_amount;
        }
 
        public void AddAmount(double amt)
        {
            m_amount += amt;
        }
    }
    /// <summary>
    /// Class for containing the list of output lists
    /// </summary>
    public class listOutputLists
    {
        private List<OutputAmount> lOL;

        //---------------------------------------------------------------------
        // Initializes the listOutputLists list
        //
        public listOutputLists()
        {
            lOL = new List<OutputAmount>();
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// List of listOutputLists 
        ///</summary>
        public List<OutputAmount> ListOutputLists
        {
            get { return lOL; }
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// add item to list
        ///</summary>
        public void Add(OutputAmount lfm)
        {
            lOL.Add(lfm);
        }
        /// <summary>
        /// Find item in list
        ///</summary>
        public OutputAmount FindOutputList(int beginTime, int pcode, int iloc)
        {
            OutputAmount tlFM = null;


            //need to do some modification here.
            //If STOCKS, then all special pools can be put into one value
            //if (pcode >= 1000 && ityp == 1) pcode = 9999;
            //if EMISSIONS, then all special pools except fuels goes into the same pool.
            //  (note that we are actually not distinguishing this because 
            if (pcode >= 2000)
            {
                pcode = 2999;   //gasses
            }
            else if (pcode >= 1000 && pcode != 1002  && pcode !=1005)   
            {
                pcode = 9999;
            }

            foreach (OutputAmount lfm in lOL)
            { 
                if (lfm.outTime == beginTime && lfm.OutPool == pcode && lfm.OutLoc == iloc)
                { 
                    return lfm;   //return the list 
                }
            }
            //if (tlFM != null) return (tlFM);
            //return null;
            tlFM = new OutputAmount(beginTime, pcode, iloc, 0);
            this.Add(tlFM);
            return tlFM;
        }

        // This output is deprecated

        // public void PrintOutputList()
        // {
        //StreamWriter fout = Landis.Extension.FPS.Program.outFile;
        //foreach (OutputAmount lout in lOL)
        //{
        //    fout.Write("{0}, {1}, {2}, {3}\n", lout.outTime, lout.OutLoc, lout.OutPool, lout.GetOutputAmount());
        //
        //}
        //return;
        // }

    }

}