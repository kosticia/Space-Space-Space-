using Content.Shared.Mobs;
using Robust.Shared.Prototypes;

namespace Content.Shared.Species.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class SlimepeopleChangeActionComponent : Component
{
    [DataField("actionPrototype", required: true)]
    public EntProtoId ActionPrototype;

    [DataField, AutoNetworkedField] 
    public EntityUid? ActionEntity;

    [DataField("popupText")]
    public string PopupText = "slimepeople-change-action-use";
}
