using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsFalse
        /// <summary>
        /// Requires that a bool is false
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsFalse(bool val, string property) =>
            IsFalse(val, property, ContractLocalization.IsFalseErrorMessage(property));

        /// <summary>
        /// Requires that a bool is false
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsFalse(bool val, string property, string message)
        {
            if (val == true)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsTrue
        /// <summary>
        /// Requires that a bool is true
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsTrue(bool val, string property) =>
            IsTrue(val, property, ContractLocalization.IsTrueErrorMessage(property));

        /// <summary>
        /// Requires that a bool is true
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsTrue(bool val, string property, string message)
        {
            if (val == false)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsNull
        /// <summary>
        /// Requires that a bool is null
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNull(bool? val, string property) =>
                IsNull(val, property, ContractLocalization.IsNullErrorMessage(property));

        /// <summary>
        /// Requires that a bool is null
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNull(bool? val, string property, string message)
        {
            if (val != null)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires that a bool is not null
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(bool? val, string property) =>
            IsNotNull(val, property, ContractLocalization.IsNotNullErrorMessage(property));

        /// <summary>
        /// Requires that a bool is not null
        /// </summary>
        /// <param name="val">bool</param>
        /// <param name="property">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(bool? val, string property, string message)
        {
            if (val == null)
                AddNotification(property, message);

            return this;
        }
        #endregion

    }
}
