using System;
using System.Collections.Generic;

namespace OnkeMakuoa_34933832.Models;

public partial class Client
{
    public Guid ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? PrimaryContactEmail { get; set; }

    public DateTime? DateOnboarded { get; set; }

    public long LedgerStartTransactionId { get; set; }

    public long? LedgerEndTransactionId { get; set; }

    public long LedgerStartSequenceNumber { get; set; }

    public long? LedgerEndSequenceNumber { get; set; }
}
