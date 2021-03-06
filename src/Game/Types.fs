module Game.Types.Model

open Game.Types.Game

type Model = GameState

type Msg =
  | Tick
  | TogglePaused
  | TriggerRestart
  | LambdaMode
  | UpdateActivePiece of Game.Types.Game.ActivePieceMsg