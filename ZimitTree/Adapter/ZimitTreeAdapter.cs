using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines.Adapters;
using Tricentis.Automation.Engines.Adapters.Attributes;
using Tricentis.Automation.Engines.Adapters.Html.Generic;
using Tricentis.Automation.Engines.Representations.Trees;
using ZimitTree.Technicals.Interfaces;

namespace ZimitTree.Adapter
{
    [SupportedTechnical(typeof(IHtmlTreeTechnical))]
    public class ZimitTreeAdapter : AbstractHtmlDomNodeAdapter<IHtmlTreeTechnical>, ITreeAdapter
    {
        public ZimitTreeAdapter(IHtmlTreeTechnical technical, Validator validator) : base(technical, validator)
        {
        }
        public override string DefaultName => "Tree";
    }
}
