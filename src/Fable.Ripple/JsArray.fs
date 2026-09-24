namespace Fable.Ripple

open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Rarr =

    /// As a replacement for resizeArray.Clear() in Fable,
    /// which emits .splice(0)
    /// Can be removed when https://github.com/fable-compiler/Fable/pull/4993 is merged
    let inline clear (arr: ResizeArray<'T>) : unit = emitJsStatement arr "$0.length = 0"
