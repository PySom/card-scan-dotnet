/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.ultimateCreditCard.Sdk {

using System;
using System.Runtime.InteropServices;

public class UltCreditCardSdkParallelDeliveryCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UltCreditCardSdkParallelDeliveryCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UltCreditCardSdkParallelDeliveryCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UltCreditCardSdkParallelDeliveryCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ultimateCreditCardSdkPINVOKE.delete_UltCreditCardSdkParallelDeliveryCallback(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  protected UltCreditCardSdkParallelDeliveryCallback() : this(ultimateCreditCardSdkPINVOKE.new_UltCreditCardSdkParallelDeliveryCallback(), true) {
    SwigDirectorConnect();
  }

  public virtual void onNewResult(UltCreditCardSdkResult newResult) {
    ultimateCreditCardSdkPINVOKE.UltCreditCardSdkParallelDeliveryCallback_onNewResult(swigCPtr, UltCreditCardSdkResult.getCPtr(newResult));
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onNewResult", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateUltCreditCardSdkParallelDeliveryCallback_0(SwigDirectoronNewResult);
    ultimateCreditCardSdkPINVOKE.UltCreditCardSdkParallelDeliveryCallback_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(UltCreditCardSdkParallelDeliveryCallback));
    return hasDerivedMethod;
  }

  private void SwigDirectoronNewResult(IntPtr newResult) {
    onNewResult((newResult == IntPtr.Zero) ? null : new UltCreditCardSdkResult(newResult, false));
  }

  public delegate void SwigDelegateUltCreditCardSdkParallelDeliveryCallback_0(IntPtr newResult);

  private SwigDelegateUltCreditCardSdkParallelDeliveryCallback_0 swigDelegate0;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(UltCreditCardSdkResult) };
}

}
