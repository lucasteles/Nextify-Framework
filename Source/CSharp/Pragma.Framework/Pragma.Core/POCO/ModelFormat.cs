using Pragma.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Pragma.Core
{
    public class ModelFormat : IModelFormat
    {
        public Color? BackColor { get; set; }
        public Color? ForeColor { get; set; }

        public bool? Bold { get; set; }

        public bool? Italic { get; set; }

        public FontFamily FontFamily { get; set; }
        public float? Size { get; set; }
        public bool? Strikeout { get; set; }
        public bool? Underline { get; set; }

    }

    internal class FormatRule<TModel>
    {
        public IModelFormat Format { get; set; }

        public Func<TModel, int, string, bool> Rule { get; set; }

    }

    public class ModelFormatRule<TModel> : IModelFormatRule<TModel>
    {
        private IList<FormatRule<TModel>> Rules = new List<FormatRule<TModel>>();

        public void Add(IModelFormat format, Func<TModel, int, string, bool> rule)
            => Rules.Add(new FormatRule<TModel> { Format = format, Rule = rule });

        public IList<IModelFormat> GetFormats(TModel model, int i, string property)
            => Rules.Where(e => e.Rule(model, i, property)).Select(e => e.Format).Reverse().ToList();

        public void Clear() => Rules.Clear();

    }

}
