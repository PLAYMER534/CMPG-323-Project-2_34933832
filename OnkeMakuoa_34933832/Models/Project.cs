using System;
using System.Collections.Generic;

namespace OnkeMakuoa_34933832.Models;

public partial class Project
{
    public Guid ProjectId { get; set; }

    public string? ProjectDescription { get; set; }

    public DateTime? ProjectCreationDate { get; set; }

    public Guid? ClientId { get; set; }

    public long LedgerStartTransactionId { get; set; }

    public long? LedgerEndTransactionId { get; set; }

    public long LedgerStartSequenceNumber { get; set; }

    public long? LedgerEndSequenceNumber { get; set; }
}
