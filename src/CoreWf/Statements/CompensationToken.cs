// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.
namespace System.Activities.Statements
{
    using System.Runtime.Serialization;
    using System.Activities.Runtime;

    [Fx.Tag.XamlVisible(false)]
    [DataContract]
    public sealed class CompensationToken
    {
        internal const string PropertyName = "System.Compensation.CompensationToken";
        internal const long RootCompensationId = 0;
            
        public CompensationToken(CompensationTokenData tokenData)
        {
            if (tokenData != null)
            {
                this.CompensationId = tokenData.CompensationId;
            }
        }
        
        [DataMember(EmitDefaultValue = false)]
        internal long CompensationId
        {
            get;
            set;
        }

        [DataMember(EmitDefaultValue = false)]
        internal bool CompensateCalled
        {
            get;
            set;
        }

        [DataMember(EmitDefaultValue = false)]
        internal bool ConfirmCalled
        {
            get;
            set;
        }
    }
}
