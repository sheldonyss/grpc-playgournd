// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: model.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPC.Playground.Messages {
  public static partial class RouteGuide
  {
    static readonly string __ServiceName = "playground.RouteGuide";

    static readonly grpc::Marshaller<global::GRPC.Playground.Messages.Point> __Marshaller_playground_Point = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Playground.Messages.Point.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRPC.Playground.Messages.Feature> __Marshaller_playground_Feature = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Playground.Messages.Feature.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRPC.Playground.Messages.Rectangle> __Marshaller_playground_Rectangle = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Playground.Messages.Rectangle.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRPC.Playground.Messages.RouteSummary> __Marshaller_playground_RouteSummary = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Playground.Messages.RouteSummary.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRPC.Playground.Messages.RouteNote> __Marshaller_playground_RouteNote = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPC.Playground.Messages.RouteNote.Parser.ParseFrom);

    static readonly grpc::Method<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.Feature> __Method_GetFeature = new grpc::Method<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.Feature>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeature",
        __Marshaller_playground_Point,
        __Marshaller_playground_Feature);

    static readonly grpc::Method<global::GRPC.Playground.Messages.Rectangle, global::GRPC.Playground.Messages.Feature> __Method_ListFeatures = new grpc::Method<global::GRPC.Playground.Messages.Rectangle, global::GRPC.Playground.Messages.Feature>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListFeatures",
        __Marshaller_playground_Rectangle,
        __Marshaller_playground_Feature);

    static readonly grpc::Method<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.RouteSummary> __Method_RecordRoute = new grpc::Method<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.RouteSummary>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "RecordRoute",
        __Marshaller_playground_Point,
        __Marshaller_playground_RouteSummary);

    static readonly grpc::Method<global::GRPC.Playground.Messages.RouteNote, global::GRPC.Playground.Messages.RouteNote> __Method_RouteChat = new grpc::Method<global::GRPC.Playground.Messages.RouteNote, global::GRPC.Playground.Messages.RouteNote>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RouteChat",
        __Marshaller_playground_RouteNote,
        __Marshaller_playground_RouteNote);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPC.Playground.Messages.ModelReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RouteGuide</summary>
    public abstract partial class RouteGuideBase
    {
      /// <summary>
      /// A simple RPC.
      ///
      /// Obtains the feature at a given position.
      ///
      /// A feature with an empty name is returned if there's no feature at the given
      /// position.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GRPC.Playground.Messages.Feature> GetFeature(global::GRPC.Playground.Messages.Point request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A server-to-client streaming RPC.
      ///
      /// Obtains the Features available within the given Rectangle.  Results are
      /// streamed rather than returned at once (e.g. in a response message with a
      /// repeated field), as the rectangle may cover a large area and contain a
      /// huge number of features.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task ListFeatures(global::GRPC.Playground.Messages.Rectangle request, grpc::IServerStreamWriter<global::GRPC.Playground.Messages.Feature> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of Points on a route being traversed, returning a
      /// RouteSummary when traversal is completed.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GRPC.Playground.Messages.RouteSummary> RecordRoute(grpc::IAsyncStreamReader<global::GRPC.Playground.Messages.Point> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of RouteNotes sent while a route is being traversed,
      /// while receiving other RouteNotes (e.g. from other users).
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task RouteChat(grpc::IAsyncStreamReader<global::GRPC.Playground.Messages.RouteNote> requestStream, grpc::IServerStreamWriter<global::GRPC.Playground.Messages.RouteNote> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RouteGuide</summary>
    public partial class RouteGuideClient : grpc::ClientBase<RouteGuideClient>
    {
      /// <summary>Creates a new client for RouteGuide</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RouteGuideClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RouteGuide that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RouteGuideClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RouteGuideClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RouteGuideClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// A simple RPC.
      ///
      /// Obtains the feature at a given position.
      ///
      /// A feature with an empty name is returned if there's no feature at the given
      /// position.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GRPC.Playground.Messages.Feature GetFeature(global::GRPC.Playground.Messages.Point request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeature(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A simple RPC.
      ///
      /// Obtains the feature at a given position.
      ///
      /// A feature with an empty name is returned if there's no feature at the given
      /// position.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GRPC.Playground.Messages.Feature GetFeature(global::GRPC.Playground.Messages.Point request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeature, null, options, request);
      }
      /// <summary>
      /// A simple RPC.
      ///
      /// Obtains the feature at a given position.
      ///
      /// A feature with an empty name is returned if there's no feature at the given
      /// position.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GRPC.Playground.Messages.Feature> GetFeatureAsync(global::GRPC.Playground.Messages.Point request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeatureAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A simple RPC.
      ///
      /// Obtains the feature at a given position.
      ///
      /// A feature with an empty name is returned if there's no feature at the given
      /// position.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GRPC.Playground.Messages.Feature> GetFeatureAsync(global::GRPC.Playground.Messages.Point request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeature, null, options, request);
      }
      /// <summary>
      /// A server-to-client streaming RPC.
      ///
      /// Obtains the Features available within the given Rectangle.  Results are
      /// streamed rather than returned at once (e.g. in a response message with a
      /// repeated field), as the rectangle may cover a large area and contain a
      /// huge number of features.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GRPC.Playground.Messages.Feature> ListFeatures(global::GRPC.Playground.Messages.Rectangle request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListFeatures(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A server-to-client streaming RPC.
      ///
      /// Obtains the Features available within the given Rectangle.  Results are
      /// streamed rather than returned at once (e.g. in a response message with a
      /// repeated field), as the rectangle may cover a large area and contain a
      /// huge number of features.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GRPC.Playground.Messages.Feature> ListFeatures(global::GRPC.Playground.Messages.Rectangle request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListFeatures, null, options, request);
      }
      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of Points on a route being traversed, returning a
      /// RouteSummary when traversal is completed.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.RouteSummary> RecordRoute(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecordRoute(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A client-to-server streaming RPC.
      ///
      /// Accepts a stream of Points on a route being traversed, returning a
      /// RouteSummary when traversal is completed.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::GRPC.Playground.Messages.Point, global::GRPC.Playground.Messages.RouteSummary> RecordRoute(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_RecordRoute, null, options);
      }
      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of RouteNotes sent while a route is being traversed,
      /// while receiving other RouteNotes (e.g. from other users).
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::GRPC.Playground.Messages.RouteNote, global::GRPC.Playground.Messages.RouteNote> RouteChat(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RouteChat(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A Bidirectional streaming RPC.
      ///
      /// Accepts a stream of RouteNotes sent while a route is being traversed,
      /// while receiving other RouteNotes (e.g. from other users).
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::GRPC.Playground.Messages.RouteNote, global::GRPC.Playground.Messages.RouteNote> RouteChat(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_RouteChat, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RouteGuideClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RouteGuideClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RouteGuideBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFeature, serviceImpl.GetFeature)
          .AddMethod(__Method_ListFeatures, serviceImpl.ListFeatures)
          .AddMethod(__Method_RecordRoute, serviceImpl.RecordRoute)
          .AddMethod(__Method_RouteChat, serviceImpl.RouteChat).Build();
    }

  }
}
#endregion
