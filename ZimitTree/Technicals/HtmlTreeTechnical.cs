using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines.Technicals.Attributes;
using Tricentis.Automation.Engines.Technicals.Html;
using ZimitTree.Technicals.Interfaces;

namespace ZimitTree.Technicals
{
    [SupportedTechnicalTypeName("XBrowser:TREE")]
    public class HtmlTreeTechnical : HtmlElementTechnical, IHtmlTreeTechnical
    {
        public HtmlTreeTechnical(IHtmlContentObjectManager remoteObjectManager, Validator validator) : base(remoteObjectManager, validator)
        {
        }
    }
}
