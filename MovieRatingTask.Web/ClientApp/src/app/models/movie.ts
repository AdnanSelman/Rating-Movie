import { Actor } from './actor';

export interface Movie {
    id: number;
    title: string;
    description: string;
    coverImageUrl: string
    releaseDate: Date;
    actors: Actor[];
    average: number;
}