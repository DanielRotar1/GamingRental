using System;

namespace LicentaTest.Data.Entities.Common
{
    public abstract class TrackedModelBase : ModelBase
    {
        #region Public Properties

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        #endregion Public Properties
    }
}