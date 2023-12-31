﻿using HR.LeaveApp.Domain.common;

namespace HR.LeaveApp.Domain;

public class LeaveRequest: BaseEntity
{
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string? RequestComments { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
    public string RequestingEmployeeId { get; set; } = string.Empty;
}


