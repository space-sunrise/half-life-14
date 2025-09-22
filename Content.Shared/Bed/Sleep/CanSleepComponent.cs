using Robust.Shared.GameStates;

namespace Content.Shared.Bed.Sleep;

[NetworkedComponent, RegisterComponent]
[AutoGenerateComponentState, AutoGenerateComponentPause(Dirty = true)]
public sealed partial class CanSleepComponent : Component
{
    [DataField]
    [AutoNetworkedField]
    public EntityUid? SleepAction;
}
