/** The vehicle item interface. */
export interface VehicleItemInterface {
  id: number;
  name: string;
  imageName: string;
  description: string;
}

/** The vehicle interface. */
export interface VehicleStoreInterface {
  items: Array<VehicleItemInterface>
}

export interface VehicleItemApiResponseInterface {
  id: number;
  name: string;
  imageName: string;
  description: string;
}
