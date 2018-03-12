using System;

namespace DataContract
{
    public sealed class Order
    {
        private readonly string _format_date = "{0:yyyy/MM/dd}";
        private readonly string _format_time = "{0:HH:mm}";

        private Nullable<DateTime> _orderDateTimeUtc;

        public string OrderNo { get; set; }

        public Nullable<DateTime> OrderDateTimeUtc
        {
            get
            {
                return this._orderDateTimeUtc;
            }
            set
            {
                this._orderDateTimeUtc = value;
            }
        }

        //xml serialzier not show readonly property to xml
        #region ReadOnly Properties
        public Nullable<DateTime> OrderDateTimeTpe
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return this.OrderDateTimeUtc.Value.AddHours(8);

                return null;
            }
        }

        public string OrderDateAsUtc
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return string.Format(this._format_date
                                        , this.OrderDateTimeUtc.Value);

                return string.Empty;
            }
        }
        public string OrderTimeAsUtc
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return string.Format(this._format_time
                                        , this.OrderDateTimeUtc.Value);

                return string.Empty;
            }
        }

        public string OrderDateAsTpe
        {
            get
            {
                if (this.OrderDateTimeTpe.HasValue == true)
                    return string.Format(this._format_date
                                        , this.OrderDateTimeTpe.Value);

                return string.Empty;
            }
        }
        public string OrderTimeAsTpe
        {
            get
            {
                if (this.OrderDateTimeTpe.HasValue == true)
                    return string.Format(this._format_time
                                        , this.OrderDateTimeTpe.Value);

                return string.Empty;
            }
        }
        #endregion

        //add set accessor for display all property to xml
        //  use NotSupportException prevent set value
        #region NotSupport ReadOnly Properties
        /*
        public Nullable<DateTime> OrderDateTimeTpe
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return this.OrderDateTimeUtc.Value.AddHours(8);

                return null;
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        public string OrderDateAsUtc
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return string.Format(this._format_date
                                        , this.OrderDateTimeUtc.Value);

                return string.Empty;
            }
            set
            {
                throw new NotSupportedException();
            }
        }
        public string OrderTimeAsUtc
        {
            get
            {
                if (this.OrderDateTimeUtc.HasValue == true)
                    return string.Format(this._format_time
                                        , this.OrderDateTimeUtc.Value);

                return string.Empty;
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        public string OrderDateAsTpe
        {
            get
            {
                if (this.OrderDateTimeTpe.HasValue == true)
                    return string.Format(this._format_date
                                        , this.OrderDateTimeTpe.Value);

                return string.Empty;
            }
            set
            {
                throw new NotSupportedException();
            }
        }
        public string OrderTimeAsTpe
        {
            get
            {
                if (this.OrderDateTimeTpe.HasValue == true)
                    return string.Format(this._format_time
                                        , this.OrderDateTimeTpe.Value);

                return string.Empty;
            }
            set
            {
                throw new NotSupportedException();
            }
        }
        */
        #endregion

    }
}

