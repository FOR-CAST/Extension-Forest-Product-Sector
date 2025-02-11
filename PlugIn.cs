//  Authors:  Caren Dymond, Sarah Beukema

using Landis.Core;
using Landis.SpatialModeling;
using System.Collections.Generic;
using Landis.Utilities;
using System.IO;
using Landis.Library.Metadata;
using System.Diagnostics;
using System;                   

namespace Landis.Extension.FPS
{
    public class PlugIn
        : ExtensionMain
    {
        public static readonly ExtensionType ExtType = new ExtensionType("output");
        public static readonly string ExtensionName = "FPS";
        private static ICore modelCore;
        private IInputParameters parameters;

        //---------------------------------------------------------------------

        public PlugIn()
            : base(ExtensionName, ExtType)
        {
        }

        //---------------------------------------------------------------------

        public override void LoadParameters(string dataFile, ICore mCore)
        {

            modelCore = mCore;
     
            InputParametersParser parser = new InputParametersParser();
            parameters = Landis.Data.Load<IInputParameters>(dataFile, parser);
 
        }

        //---------------------------------------------------------------------

        public static ICore ModelCore
        {
            get
            {
                return modelCore;
            }
        }
       
        public override void Initialize()
        {
        }

        //---------------------------------------------------------------------

        public override void Run()
        {

        }

        // ADD CUSTOM COHORT FIELDS HERE
        public override void AddCohortData()
        {
            return;
        }
    }

}
