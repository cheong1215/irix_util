﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlarm
{
   public static class WinVolume
   {
      [ComImport]
      [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
      private interface IMMDeviceEnumerator
      {
         void _VtblGap1_1();
         int GetDefaultAudioEndpoint(int dataFlow, int role, out IMMDevice ppDevice);
      }
      private static class MMDeviceEnumeratorFactory
      {
         public static IMMDeviceEnumerator CreateInstance()
         {
            return (IMMDeviceEnumerator)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("BCDE0395-E52F-467C-8E3D-C4579291692E"))); // a MMDeviceEnumerator
         }
      }
      [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
      private interface IMMDevice
      {
         int Activate([MarshalAs(UnmanagedType.LPStruct)] Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
      }

      [Guid("5CDF2C82-841E-4546-9722-0CF74078229A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
      public interface IAudioEndpointVolume
      {
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE RegisterControlChangeNotify(/* [in] */__in IAudioEndpointVolumeCallback *pNotify) = 0;
         int RegisterControlChangeNotify(IntPtr pNotify);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE UnregisterControlChangeNotify(/* [in] */ __in IAudioEndpointVolumeCallback *pNotify) = 0;
         int UnregisterControlChangeNotify(IntPtr pNotify);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE GetChannelCount(/* [out] */ __out UINT *pnChannelCount) = 0;
         int GetChannelCount(ref uint pnChannelCount);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE SetMasterVolumeLevel( /* [in] */ __in float fLevelDB,/* [unique][in] */ LPCGUID pguidEventContext) = 0;
         int SetMasterVolumeLevel(float fLevelDB, Guid pguidEventContext);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE SetMasterVolumeLevelScalar( /* [in] */ __in float fLevel,/* [unique][in] */ LPCGUID pguidEventContext) = 0;
         int SetMasterVolumeLevelScalar(float fLevel, Guid pguidEventContext);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE GetMasterVolumeLevel(/* [out] */ __out float *pfLevelDB) = 0;
         int GetMasterVolumeLevel(ref float pfLevelDB);
         //virtual /* [helpstring] */ HRESULT STDMETHODCALLTYPE GetMasterVolumeLevelScalar( /* [out] */ __out float *pfLevel) = 0;
         int GetMasterVolumeLevelScalar(ref float pfLevel);
      }

      public static void SetMasterVolume(int level)
      {
         if (level < 0 || level > 100)
         {
            return;
         }

         IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
         IMMDevice speakers;
         const int eRender = 0;
         const int eMultimedia = 1;
         deviceEnumerator.GetDefaultAudioEndpoint(eRender, eMultimedia, out speakers);

         object aepv_obj;
         speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out aepv_obj);
         IAudioEndpointVolume aepv = (IAudioEndpointVolume)aepv_obj;
         Guid ZeroGuid = new Guid();
         int res = aepv.SetMasterVolumeLevelScalar(level / 100f, ZeroGuid);
      }

      public static int GetMasterVolume()
      {
         IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
         IMMDevice speakers;
         const int eRender = 0;
         const int eMultimedia = 1;
         deviceEnumerator.GetDefaultAudioEndpoint(eRender, eMultimedia, out speakers);

         object aepv_obj;
         speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out aepv_obj);
         IAudioEndpointVolume aepv = (IAudioEndpointVolume)aepv_obj;
         //Guid ZeroGuid = new Guid();
         //int res = aepv.SetMasterVolumeLevelScalar(level / 100f, ZeroGuid);
         float masterLevel = 0.00f;
         aepv.GetMasterVolumeLevelScalar(ref masterLevel);
         return Convert.ToInt32(masterLevel * 100);
      }

      public static int GetMasterMicVolume()
      {
         IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
         IMMDevice speakers;
         const int eCapture = 1;
         const int eMultimedia = 1;
         deviceEnumerator.GetDefaultAudioEndpoint(eCapture, eMultimedia, out speakers);

         object aepv_obj;
         speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out aepv_obj);
         IAudioEndpointVolume aepv = (IAudioEndpointVolume)aepv_obj;
         //Guid ZeroGuid = new Guid();
         //int res = aepv.SetMasterVolumeLevelScalar(level / 100f, ZeroGuid);
         float masterLevel = 0.00f;
         aepv.GetMasterVolumeLevelScalar(ref masterLevel);
         return Convert.ToInt32(masterLevel * 100);
      }

      public static void SetMasterMicVolume(int level)
      {
         if (level < 0 || level > 100)
         {
            return;
         }

         IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
         IMMDevice speakers;
         const int eCapture = 1;
         const int eMultimedia = 1;
         deviceEnumerator.GetDefaultAudioEndpoint(eCapture, eMultimedia, out speakers);

         object aepv_obj;
         speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out aepv_obj);
         IAudioEndpointVolume aepv = (IAudioEndpointVolume)aepv_obj;
         Guid ZeroGuid = new Guid();
         int res = aepv.SetMasterVolumeLevelScalar(level / 100f, ZeroGuid);
      }


   }
}
