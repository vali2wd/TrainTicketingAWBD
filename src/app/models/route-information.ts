import { ITimetable } from "./timetable";

export interface IRouteInformation{
        mainStation: string;
        cities: string[];
        timetable: ITimetable[];
}