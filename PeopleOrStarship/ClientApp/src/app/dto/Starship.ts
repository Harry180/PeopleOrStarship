export interface Starship {
  id: number,
  name: string,
  model: string,
  manufacturer: string,
  costInCredits: bigint,
  length: number,
  maxAtmospheringSpeed: string,
  crew: number,
  passengers:number,
  cargoCapacity: bigint,
  consumables: string,
  hyperdriveRating: number,
  starshipClass: string,
  winCount: number,
  won: boolean
}
