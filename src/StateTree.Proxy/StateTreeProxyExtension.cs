using System;
using ImpromptuInterface;
using Skclusive.Mobx.Observable;

namespace Skclusive.Mobx.StateTree.Proxy
{
    public static class StateTreeProxyExtension
    {
        public static TInterface ActAs<TInterface>(this IObservableObject observable, params Type[] otherInterfaces) where TInterface : class
        {
            return observable.ActLike<TInterface>(otherInterfaces);
        }

        public static TInterface ActAsProxy<TInterface>(this IObservableObject observable) where TInterface : class
        {
            return observable.ActAs<TInterface>(typeof(IObservableObject<TInterface, INode>));
        }
    }
}
