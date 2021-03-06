﻿using System.Collections.Generic;
using System.Linq;
using NoRM.BSON;

namespace NoRM.Responses
{
    /// <summary>
    /// The explain response.
    /// </summary>
    public class ExplainResponse : Explain, IFlyweight
    {
        public int nscanned { get; set; }
        public int n { get; set; }
        public int millis { get; set; }
        public Explain oldPlan { get; set; }
        public Explain[] allPlans { get; set; }
    }

    /// <summary>
    /// The explain.
    /// </summary>
    public class Explain
    {
        public string cursor { get; set; }
        internal Flyweight startKey { get; set; }
        internal Flyweight endKey { get; set; }

        public Dictionary<string, string> ExplainStartKey
        {
            get
            {
                var keys = new Dictionary<string, string>();
                if (startKey != null)
                {
                    var properties = startKey.AllProperties();

                    properties.ToList().ForEach(p => keys.Add(p.PropertyName, p.Value.ToString()));
                }

                return keys;
            }
        }

        public Dictionary<string, string> ExplainEndKey
        {
            get
            {
                var keys = new Dictionary<string, string>();
                if (endKey != null)
                {
                    var properties = endKey.AllProperties();
                
                    properties.ToList().ForEach(p => keys.Add(p.PropertyName, p.Value.ToString()));
                }

                return keys;
            }
        }
    }
}