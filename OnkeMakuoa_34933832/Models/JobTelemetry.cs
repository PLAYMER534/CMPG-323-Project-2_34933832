using System;
using System.Collections.Generic;

namespace OnkeMakuoa_34933832.Models;

public partial class JobTelemetry
{
    internal object ProjectID;
    internal decimal TimeSaved;
    internal decimal CostSaved;

    public int Id { get; set; }

    public string? QueueId { get; set; }

    public string? StepDescription { get; set; }

    public int? HumanTime { get; set; }

    public string? UniqueReference { get; set; }

    public string? UniqueReferenceType { get; set; }

    public string? BusinessFunction { get; set; }

    public string? Geography { get; set; }

    public bool? ExcludeFromTimeSaving { get; set; }

    public string? AdditionalInfo { get; set; }

    public DateTime EntryDate { get; set; }

    public long LedgerStartTransactionId { get; set; }

    public long? LedgerEndTransactionId { get; set; }

    public long LedgerStartSequenceNumber { get; set; }

    public long? LedgerEndSequenceNumber { get; set; }
}
