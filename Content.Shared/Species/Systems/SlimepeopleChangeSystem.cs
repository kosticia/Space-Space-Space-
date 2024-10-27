using Content.Shared.Species.Components;
using Content.Shared.Actions;
using Content.Shared.Mobs;
using Content.Shared.Mobs.Components;
using Content.Shared.Popups;
using Robust.Shared.Prototypes;
using Content.Shared.MagicMirror;


namespace Content.Shared.Species;

public sealed partial class SlimepeopleChangeActionSystem : EntitySystem
{
    [Dependency] private readonly SharedPopupSystem _popupSystem = default!;
    [Dependency] private readonly SharedMagicMirrorSystem _magicmirrorSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SlimepeopleChangeActionComponent, SlimepeopleChangeActionEvent>(OnSlimepeopleChangeAction);
    }

    private void OnSlimepeopleChangeAction(EntityUid uid, SlimepeopleChangeActionComponent comp, SlimepeopleChangeActionEvent args)
    {
        _popupSystem.PopupClient(Loc.GetString(comp.PopupText, ("name", uid)), uid, uid);
        _magicmirrorSystem.OnMagicMirrorInteract(uid, true);
    }
       


    public sealed partial class SlimepeopleChangeActionEvent : InstantActionEvent { } 
}
