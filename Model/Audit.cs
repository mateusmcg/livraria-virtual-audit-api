using System;

public class Audit
{
    public DateTime ExecutionDate { get; set; }
    public int UserId { get; set; }
    public ActionType ActionType { get; set; }
    public object ObjectPreviousState { get; set; }
    public object ObjectNewState { get; set; }
}