//namespace Cloudlucky.GuardClauses.Future;

//public static class EnumerableExtensions
//{
//    public static TSource? ElementAtOrNotFound<TSource>(this IEnumerable<TSource> source, Index index)
//    {
//        var result = source.ElementAtOrDefault(index);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? ElementAtOrNotFound<TSource>(this IEnumerable<TSource> source, int index)
//    {
//        var result = source.ElementAtOrDefault(index);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource FirstOrNotFound<TSource>(this IEnumerable<TSource> source)
//    {
//        var result = source.FirstOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource FirstOrNotFound<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.FirstOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource LastOrNotFound<TSource>(this IEnumerable<TSource> source)
//    {
//        var result = source.LastOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource LastOrNotFound<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.LastOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? SingleOrNotFound<TSource>(this IEnumerable<TSource> source)
//    {
//        var result = source.SingleOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? SingleOrNotFound<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.SingleOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }
//}

//// TODO test with ef core, xml, etc and do the async versions
//public static class QueryableExtensions
//{
//    public static TSource? ElementAtOrNotFound<TSource>(this IQueryable<TSource> source, Index index)
//    {
//        var result = source.ElementAtOrDefault(index);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? ElementAtOrNotFound<TSource>(this IQueryable<TSource> source, int index)
//    {
//        var result = source.ElementAtOrDefault(index);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource FirstOrNotFound<TSource>(this IQueryable<TSource> source)
//    {
//        var result = source.FirstOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource FirstOrNotFound<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.FirstOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource LastOrNotFound<TSource>(this IQueryable<TSource> source)
//    {
//        var result = source.LastOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource LastOrNotFound<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.LastOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? SingleOrNotFound<TSource>(this IQueryable<TSource> source)
//    {
//        var result = source.SingleOrDefault();

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }

//    public static TSource? SingleOrNotFound<TSource>(this IQueryable<TSource> source, Func<TSource, bool> predicate)
//    {
//        var result = source.SingleOrDefault(predicate);

//        return result is null
//            ? throw new NotFoundException()
//            : result;
//    }
//}

//public class NotFoundException : Exception
//{

//}