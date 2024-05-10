using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace LicentaTest.Data.Entities.Common
{
    public abstract class ModelBase
    {
        #region Protected Fields

        protected ILazyLoader lazyLoader;

        #endregion Protected Fields

        #region Public Properties

        public Guid Id { get; set; }

        #endregion Public Properties
    }
}
