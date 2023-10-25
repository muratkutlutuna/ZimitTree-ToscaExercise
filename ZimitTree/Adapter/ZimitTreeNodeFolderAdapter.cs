using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines.Adapters;
using Tricentis.Automation.Engines.Adapters.Attributes;
using Tricentis.Automation.Engines.Adapters.Html.Generic;
using Tricentis.Automation.Engines.Technicals.Html;

namespace ZimitTree.Adapter
{
    [SupportedTechnical(typeof(IHtmlElementTechnical))]
    public class ZimitTreeNodeFolderAdapter : AbstractHtmlDomNodeAdapter<IHtmlElementTechnical>, ITreeNodeAdapter
    {
        public ZimitTreeNodeFolderAdapter(IHtmlElementTechnical technical, Validator validator) : base(technical, validator)
        {
        }

        public System.Drawing.PointF? ExpandCollapsePoint => throw new NotImplementedException();

        public bool Expanded { get; }

        public bool Selected { get; }

        public string Name => throw new NotImplementedException();

        public void Collapse()
        {
            throw new NotImplementedException();
        }

        public void Expand()
        {
            throw new NotImplementedException();
        }

        public void Select()
        {
            throw new NotImplementedException();
        }
    }
}
