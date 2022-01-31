namespace Cloudlucky.GuardClauses;

public delegate bool GuardCondition();

public static class GuardConditionExtensions
{
    public static void OtherwiseThrow(this GuardCondition guardCondition, Func<Exception> exceptionToThrow)
    {
        if (!guardCondition.Invoke())
        {
            throw exceptionToThrow.Invoke();
        }
    }
}
