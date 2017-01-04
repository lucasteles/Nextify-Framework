
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pragma.Core.POCO
{
    public class ExpressionAppender<TModel>
    {
        private readonly List<Expression<Func<TModel, object>>> _expressions;
        private readonly object _addLock = new object();
        private readonly object _evaluateLock = new object();

        public object AddLock
        {
            get
            {
                return _addLock;
            }
        }

        public ExpressionAppender()
        {
            _expressions = new List<Expression<Func<TModel, object>>>();
        }

        public ExpressionAppender<TModel> Add(Expression<Func<TModel, object>> exp)
        {
            lock (AddLock)
                _expressions.Add(exp);

            return this;
        }

        public Expression<Func<TModel, object>>[] Eval()
        {
            var output = default(Expression<Func<TModel, object>>[]);

            lock (_evaluateLock)
            {
                output = _expressions.ToArray();
                _expressions.Clear();
            }

            return output;
        }
    }
}
