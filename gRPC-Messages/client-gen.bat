setlocal
set PROTOC=%UserProfile%\.nuget\packages\Grpc.Tools\1.15.0\tools\windows_x64\protoc.exe
set PLUGIN=%UserProfile%\.nuget\packages\Grpc.Tools\1.15.0\tools\windows_x64\grpc_csharp_plugin.exe

%PROTOC% -I./ --csharp_out RouteGuide --grpc_out RouteGuide ./model.proto --plugin=protoc-gen-grpc=%PLUGIN%