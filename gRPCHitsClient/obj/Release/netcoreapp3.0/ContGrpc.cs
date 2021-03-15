// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/cont.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCHitsClient {
  public static partial class CounterSvc
  {
    static readonly string __ServiceName = "Cont.CounterSvc";

    static readonly grpc::Marshaller<global::gRPCHitsClient.CounterRequest> __Marshaller_Cont_CounterRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCHitsClient.CounterRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCHitsClient.CounterReply> __Marshaller_Cont_CounterReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCHitsClient.CounterReply.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPCHitsClient.CounterRequest, global::gRPCHitsClient.CounterReply> __Method_GenerateValue = new grpc::Method<global::gRPCHitsClient.CounterRequest, global::gRPCHitsClient.CounterReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateValue",
        __Marshaller_Cont_CounterRequest,
        __Marshaller_Cont_CounterReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCHitsClient.ContReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CounterSvc</summary>
    public partial class CounterSvcClient : grpc::ClientBase<CounterSvcClient>
    {
      /// <summary>Creates a new client for CounterSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CounterSvcClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CounterSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CounterSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CounterSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CounterSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::gRPCHitsClient.CounterReply GenerateValue(global::gRPCHitsClient.CounterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateValue(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPCHitsClient.CounterReply GenerateValue(global::gRPCHitsClient.CounterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateValue, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPCHitsClient.CounterReply> GenerateValueAsync(global::gRPCHitsClient.CounterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateValueAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPCHitsClient.CounterReply> GenerateValueAsync(global::gRPCHitsClient.CounterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateValue, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CounterSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CounterSvcClient(configuration);
      }
    }

  }
}
#endregion
