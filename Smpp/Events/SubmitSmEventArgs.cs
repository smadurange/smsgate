using System;
using Smpp.Requests;

namespace Smpp.Events
{
    public class SubmitSmEventArgs : EventArgs
    {
        public SubmitSmEventArgs(string messageId, SubmitSm submitSm)
        {
            MessageId = messageId;
            SubmitSm = submitSm;
        }

        public string MessageId { get; }

        public SubmitSm SubmitSm { get; }
    }
}
