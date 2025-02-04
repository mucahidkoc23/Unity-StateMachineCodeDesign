using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    public PlayerGroundedState(PlayerStateMachine stateMachine, Player player, string animBoolName) : base(stateMachine, player, animBoolName)
    {
    }
    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();
        if (Input.GetKey(KeyCode.Mouse0) )
        {
            stateMachine.ChangeState(player.PrimaryAttack);
        }

        if (!player.IsGroundedDetected())
        {
            stateMachine.ChangeState(player.AirState);
        }

        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundedDetected())
        {
            stateMachine.ChangeState(player.JumpState);
        }

    }
    public override void Exit()
    {
        base.Exit();
    }
}
