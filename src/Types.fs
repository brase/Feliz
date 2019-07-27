namespace Feliz

/// Describes a basic react element
type IReactProperty = interface end

/// Describes a basic style attribute
type IStyleAttribute = interface end

[<AutoOpen>]
module HookBindings =
    let Hooks = Fable.React.HookBindings.Hooks