import { Actor } from './actor';

export interface Show {
    id: number;
    title: string;
    description: string;
    coverImageUrl: string
    releaseDate: Date;
    actors: Actor[];
    average: number;
}