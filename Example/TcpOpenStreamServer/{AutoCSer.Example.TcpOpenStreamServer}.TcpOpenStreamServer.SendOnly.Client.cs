//本文件由程序自动生成,请不要自行修改
using System;
using AutoCSer;

#if NoAutoCSer
#else
#pragma warning disable
namespace AutoCSer.Example.TcpOpenStreamServer.TcpStreamClient
{
        internal partial class SendOnly
        {
            /// <summary>
            /// AutoCSer.Example.TcpOpenStreamServer.SendOnly TCP服务参数
            /// </summary>
            public sealed class TcpOpenStreamServer
            {

                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false)]
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct _p1
                {
                    public int left;
                    public int right;
                }
            }
            /// <summary>
            /// TCP客户端
            /// </summary>
            public class TcpOpenStreamClient : AutoCSer.Net.TcpOpenStreamServer.MethodClient<TcpOpenStreamClient>
            {
                /// <summary>
                /// TCP调用客户端
                /// </summary>
                /// <param name="attribute">TCP调用服务器端配置信息</param>
                /// <param name="log">日志接口</param>
                public TcpOpenStreamClient(AutoCSer.Net.TcpOpenStreamServer.ServerAttribute attribute = null, AutoCSer.Log.ILog log = null)
                {
                    if (attribute == null)
                    {
                        attribute = AutoCSer.Config.Loader.Get<AutoCSer.Net.TcpOpenStreamServer.ServerAttribute>("AutoCSer.Example.TcpOpenStreamServer.SendOnly") ?? AutoCSer.Json.Parser.Parse<AutoCSer.Net.TcpOpenStreamServer.ServerAttribute>(@"{""CheckSeconds"":59,""ClientOutputSleep"":-1,""ClientSegmentationCopyPath"":null,""ClientSendBufferMaxSize"":0x100000,""ClientTryCreateSleep"":1000,""GenericType"":null,""Host"":""127.0.0.1"",""IsAttribute"":true,""IsAutoClient"":false,""IsAutoServer"":true,""IsBaseTypeAttribute"":false,""IsClientAwaiter"":false,""IsJsonSerialize"":true,""IsMarkData"":false,""IsSegmentation"":true,""IsServerBuildOutputThread"":false,""IsSimpleSerialize"":true,""MaxInputSize"":0x3FF4,""MaxVerifyDataSize"":1024,""MemberFilters"":""Instance"",""MinCompressSize"":0,""Name"":null,""Port"":0x358A,""ReceiveBufferSize"":""Kilobyte8"",""ReceiveVerifyCommandSeconds"":9,""SendBufferSize"":""Kilobyte8"",""ServerOutputSleep"":-1,""ServerSendBufferMaxSize"":0,""ServerTaskType"":""Queue"",""VerifyString"":null,""TypeId"":{}}");
                        if (attribute.Name == null) attribute.Name = "AutoCSer.Example.TcpOpenStreamServer.SendOnly";
                    }
                    _TcpClient_ = new AutoCSer.Net.TcpOpenStreamServer.Client<TcpOpenStreamClient>(this, attribute, log);
                    if (attribute.IsAutoClient) _TcpClient_.TryCreateSocket();
                }

                private static readonly AutoCSer.Net.TcpServer.CommandInfo _c0 = new AutoCSer.Net.TcpServer.CommandInfo { Command = 0 + 128, InputParameterIndex = 1 , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize, IsSendOnly = 1, TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous };

                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void SetSum(int left, int right)
                {
                    TcpOpenStreamServer._p1 _inputParameter_ = new TcpOpenStreamServer._p1
                    {
                        
                        left = left,
                        
                        right = right,
                    };
                    _TcpClient_.Sender.CallOnly(_c0, ref _inputParameter_);
                }

            }
        }
}
#endif