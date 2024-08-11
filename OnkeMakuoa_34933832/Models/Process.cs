using System;
using System.Collections.Generic;

namespace OnkeMakuoa_34933832.Models;

public partial class Process
{
    public Guid ProcessId { get; set; }

    public string ProcessName { get; set; } = null!;

    public string ProcessType { get; set; } = null!;

    public bool IsFramework { get; set; }

    public bool RequiresDefaultConfig { get; set; }

    public string Submitter { get; set; } = null!;

    public DateTime DateSubmitted { get; set; }

    public string? ProcessConfigUrl { get; set; }

    public string? ReportUrl { get; set; }

    public Guid? ProjectId { get; set; }

    public string? DefaultGeography { get; set; }

    public string? DefaultBusinessFunction { get; set; }

    public long LedgerStartTransactionId { get; set; }

    public long? LedgerEndTransactionId { get; set; }

    public long LedgerStartSequenceNumber { get; set; }

    public long? LedgerEndSequenceNumber { get; set; }
}
