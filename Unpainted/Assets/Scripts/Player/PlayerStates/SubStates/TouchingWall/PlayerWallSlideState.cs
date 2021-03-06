using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallSlideState : PlayerTouchingWallState
{
    public PlayerWallSlideState(Player player, PlayerStateMachine playerStateMachine, PlayerData playerData, PlayerParticleHandler particleHandler, string m_AnimatorBoolName) : base(player, playerStateMachine, playerData, particleHandler, m_AnimatorBoolName)
    {
    }

    public override void LogicUppdate()
    {
        base.LogicUppdate();
        core.Movement.SetVelocityY(-playerData.wallSlideVelocity);


        if (jumpInput && player.DoubleJumpState.canDoubleJump)
        {
            player.InputHandler.UseJumpInput();
            stateMachine.ChangeState(player.DoubleJumpState);
        }
    }

}
