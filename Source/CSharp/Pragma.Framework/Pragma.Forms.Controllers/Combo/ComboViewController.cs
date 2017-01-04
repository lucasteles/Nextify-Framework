using Pragma.Core;
using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pragma.Business.Abstraction;

namespace Pragma.Forms.Controllers
{
    public class ComboViewController<TModel, TKey, TView, TViewKey> : ComboViewBaseController<TModel, TKey, TView, TViewKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public class ComboViewController<TModel, TKey, TView> : ComboViewController<TModel, TKey, TView, TKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public class ComboViewController<TModel, TKey> : ComboViewController<TModel, TKey, TModel> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public class ComboViewController<TModel> : ComboViewController<TModel, int, TModel> where TModel : class, IModelWithKey, new()
    {
        public ComboViewController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }

}
