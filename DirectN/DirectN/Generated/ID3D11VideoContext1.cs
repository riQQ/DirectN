﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(2646,5)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [Guid("a7f026da-a5f8-4487-a564-15e34357651e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext1 : ID3D11VideoContext
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_( *pDataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11VideoContext
        [PreserveSig]
        new HRESULT GetDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, /* [annotation] _Out_ */ out uint pBufferSize, /* [annotation] _Outptr_result_bytebuffer_(*pBufferSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppBuffer);
        
        [PreserveSig]
        new HRESULT ReleaseDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
        
        [PreserveSig]
        new HRESULT DecoderBeginFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ID3D11VideoDecoderOutputView pView, uint ContentKeySize, /* [annotation] _In_reads_bytes_opt_(ContentKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object pContentKey);
        
        [PreserveSig]
        new HRESULT DecoderEndFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder);
        
        [PreserveSig]
        new HRESULT SubmitDecoderBuffers(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ uint NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC[] pBufferDesc);
        
        [PreserveSig]
        new int DecoderExtension(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
        
        [PreserveSig]
        new void VideoProcessorSetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* optional(RECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool YCbCr, /* [annotation] _In_ */ ref D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        new void VideoProcessorSetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, /* [annotation] _In_ */ uint StreamIndex);
        
        [PreserveSig]
        new void VideoProcessorSetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ SIZE Size);
        
        [PreserveSig]
        new void VideoProcessorSetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        new int VideoProcessorSetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new void VideoProcessorGetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool Enabled, /* [annotation] _Out_ */ out RECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pYCbCr, /* [annotation] _Out_ */ out D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        new void VideoProcessorGetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, /* [annotation] _Out_ */ out uint pStreamIndex);
        
        [PreserveSig]
        new void VideoProcessorGetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out SIZE pSize);
        
        [PreserveSig]
        new void VideoProcessorGetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        new int VideoProcessorGetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new void VideoProcessorSetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_FRAME_FORMAT FrameFormat);
        
        [PreserveSig]
        new void VideoProcessorSetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, /* [annotation] _In_ */ bool RepeatFrame, /* optional(DXGI_RATIONAL) */ IntPtr pCustomRate);
        
        [PreserveSig]
        new void VideoProcessorSetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(RECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(RECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Alpha);
        
        [PreserveSig]
        new void VideoProcessorSetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ uint Count, /* [annotation] _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        new void VideoProcessorSetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(DXGI_RATIONAL) */ IntPtr pSourceAspectRatio, /* optional(DXGI_RATIONAL) */ IntPtr pDestinationAspectRatio);
        
        [PreserveSig]
        new void VideoProcessorSetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Lower, /* [annotation] _In_ */ float Upper);
        
        [PreserveSig]
        new void VideoProcessorSetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, /* [annotation] _In_ */ bool LeftViewFrame0, /* [annotation] _In_ */ bool BaseViewFrame0, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, /* [annotation] _In_ */ int MonoOffset);
        
        [PreserveSig]
        new void VideoProcessorSetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        new void VideoProcessorSetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ int Level);
        
        [PreserveSig]
        new int VideoProcessorSetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new void VideoProcessorGetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
        
        [PreserveSig]
        new void VideoProcessorGetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, /* [annotation] _Out_ */ out bool pRepeatFrame, /* [annotation] _Out_ */ out DXGI_RATIONAL pCustomRate);
        
        [PreserveSig]
        new void VideoProcessorGetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out RECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out RECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pAlpha);
        
        [PreserveSig]
        new void VideoProcessorGetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ uint Count, /* [annotation] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        new void VideoProcessorGetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out DXGI_RATIONAL pSourceAspectRatio, /* [annotation] _Out_ */ out DXGI_RATIONAL pDestinationAspectRatio);
        
        [PreserveSig]
        new void VideoProcessorGetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pLower, /* [annotation] _Out_ */ out float pUpper);
        
        [PreserveSig]
        new void VideoProcessorGetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, /* [annotation] _Out_ */ out bool pLeftViewFrame0, /* [annotation] _Out_ */ out bool pBaseViewFrame0, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, /* [annotation] _Out_ */ out int MonoOffset);
        
        [PreserveSig]
        new void VideoProcessorGetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        new void VideoProcessorGetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out int pLevel);
        
        [PreserveSig]
        new int VideoProcessorGetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT VideoProcessorBlt(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ID3D11VideoProcessorOutputView pView, /* [annotation] _In_ */ uint OutputFrame, /* [annotation] _In_ */ uint StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_VIDEO_PROCESSOR_STREAM[] pStreams);
        
        [PreserveSig]
        new HRESULT NegotiateCryptoSessionKeyExchange(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new void EncryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* [annotation] _In_ */ uint IVSize, /* [annotation] _Inout_opt_bytecount_(IVSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pIV);
        
        [PreserveSig]
        new void DecryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* optional(D3D11_ENCRYPTED_BLOCK_INFO) */ IntPtr pEncryptedBlockInfo, /* [annotation] _In_ */ uint ContentKeySize, /* [annotation] _In_reads_bytes_opt_(ContentKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object pContentKey, /* [annotation] _In_ */ uint IVSize, /* [annotation] _Inout_opt_bytecount_(IVSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pIV);
        
        [PreserveSig]
        new void StartSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint RandomNumberSize, /* [annotation] _Out_writes_bytes_(RandomNumberSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pRandomNumber);
        
        [PreserveSig]
        new void FinishSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession);
        
        [PreserveSig]
        new HRESULT GetEncryptionBltKey(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint KeySize, /* [annotation] _Out_writes_bytes_(KeySize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pReadbackKey);
        
        [PreserveSig]
        new HRESULT NegotiateAuthenticatedChannelKeyExchange(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT QueryAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pInput, /* [annotation] _In_ */ uint OutputSize, /* [annotation] _Out_writes_bytes_(OutputSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pOutput);
        
        [PreserveSig]
        new HRESULT ConfigureAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pInput, /* [annotation] _Out_ */ out D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
        
        [PreserveSig]
        new void VideoProcessorSetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
        
        [PreserveSig]
        new void VideoProcessorGetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
        
        // ID3D11VideoContext1
        [PreserveSig]
        HRESULT SubmitDecoderBuffers1(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ uint NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC1[] pBufferDesc);
        
        [PreserveSig]
        HRESULT GetDataForNewHardwareKey(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint PrivateInputSize, /* [annotation] _In_reads_(PrivateInputSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pPrivatInputData, /* [annotation] _Out_ */ out ulong pPrivateOutputData);
        
        [PreserveSig]
        HRESULT CheckCryptoSessionStatus(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _Out_ */ out D3D11_CRYPTO_SESSION_STATUS pStatus);
        
        [PreserveSig]
        HRESULT DecoderEnableDownsampling(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc, /* [annotation] _In_ */ uint ReferenceFrameCount);
        
        [PreserveSig]
        HRESULT DecoderUpdateDownsampling(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc);
        
        [PreserveSig]
        void VideoProcessorSetOutputColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetOutputShaderUsage(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool ShaderUsage);
        
        [PreserveSig]
        void VideoProcessorGetOutputColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetOutputShaderUsage(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pShaderUsage);
        
        [PreserveSig]
        void VideoProcessorSetStreamColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetStreamMirror(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ bool FlipHorizontal, /* [annotation] _In_ */ bool FlipVertical);
        
        [PreserveSig]
        void VideoProcessorGetStreamColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetStreamMirror(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out bool pFlipHorizontal, /* [annotation] _Out_ */ out bool pFlipVertical);
        
        [PreserveSig]
        HRESULT VideoProcessorGetBehaviorHints(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint OutputWidth, /* [annotation] _In_ */ uint OutputHeight, /* [annotation] _In_ */ DXGI_FORMAT OutputFormat, /* [annotation] _In_ */ uint StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT[] pStreams, /* [annotation] _Out_ */ out uint pBehaviorHints);
    }
}