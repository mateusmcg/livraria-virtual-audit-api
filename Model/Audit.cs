using System;

public class Audit
{
    public DateTime ExecutionDate { get; set; }
    public object ObjectPreviousState { get; set; }
    public object ObjectNewState { get; set; }
}