using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pragma.Core
{
    public interface IModelFormat
    {
        Color? BackColor { get; set; }

        Color? ForeColor { get; set; }

        bool? Bold { get; set; }

        bool? Italic { get; set; }

        FontFamily FontFamily { get; set; }
        float? Size { get; set; }
        bool? Strikeout { get; set; }
        bool? Underline { get; set; }

    }

    public interface IModelFormatRule<TModel>
    {
        void Add(IModelFormat format, Func<TModel, int, string, bool> rule);
        IList<IModelFormat> GetFormats(TModel model, int i, string property);

        void Clear();

    }

}