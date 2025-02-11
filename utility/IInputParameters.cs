//  Authors:  Caren Dymond, Sarah Beukema

using Landis.Core;
using Landis.Utilities;
using Landis.Library.Parameters;

using System.Collections.Generic;
using System.Diagnostics;

namespace Landis.Extension.FPS
{
    /// <summary>
    /// The parameters for biomass succession.
    /// </summary>
    public interface IInputParameters
    //    : Dynamic.IParameters
    {
        int CellLength { get; set; }
        int YearsAfter { get; set;}
        int MaxHarvYear { get; set; }
        string HarvestFileLive { get;set;}
        string HarvestFileDOM { get; set; }
        string ManagementUnitFile { get; set; }
        int OutputInt { get; set; }
        listFM ListFM { get; set; }
        SpeciesGroupList ListSPG { get; set; }
        listMillPrimary ListMillPrime { get; set; }
        listPrimaryToMarket ListPrimaryMarket { get; set; }
        listPrimaryToSecond ListPrimarySecondary { get; set; }
        listSecondToRetirement ListSecondaryRetirement { get; set; }
        listRetirementToDisposal ListRetireDisposal { get; set; }
       listLFGasManagement ListLFGasManagement { get; set; }

    }
}
