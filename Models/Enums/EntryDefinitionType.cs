namespace CoreDemo.Models.Enums;

public enum EntryDefinitionType
{
    /// <summary>
    /// 'Ingen' is the fallback value if you receive an unexpected value from the API
    /// </summary>
    Ingen,
    Boligselgerforsikring,
    EierskiftegebyrSelger,
    EierskiftegebyrKjøper,
    EkstratjenesterMegler,
    EkstratjenesterSaksbehandler,
    FotoVideo,
    Hjemmelserklæring,
    InternettAnnonsering,
    KommunaleOpplysninger,
    Salgssum,
    Megleropplysninger,
    Meglerprovisjon,
    Markedspakke,
    OmkostningKjøper,
    OmkostningSelger,
    Oppgjørsgebyr,
    OpplysningerFraForretningsfører,
    PanteattestKjøper,
    PanteattestKjøperInkMva,
    PanteattestSelger,
    PanteattestSelgerInkMva,
    Servitutter,
    Takst,
    Tilretteleggingshonorar,
    TinglGebyrHjemmelserklæring,
    TinglGebyrObligasjon,
    TinglGebyrSkjøte,
    UtleggKjøperInkMva,
    UtleggKjøperMvaFritt,
    UtleggSelgerInkMva,
    UtleggSelgerMvaFritt,
    Sikringsobligasjon,
    Visninger,
    OppdateringFinnNo,
    GebyrUtlysingForkjøpsrett,
    RenterSelger,
    RenterKjøper,
    InnbetalingKjøper,
    InnbetalingRenter,
    InnbetalingSelger,
    InnbetalingDrift,
    InnbetalingKjøperTilDrift,
    InnbetalingSelgerTilDrift,
    InnbetalingAndreKundefordringerTilKlient,
    InnbetalingAndreKundefordringerTilDrift,

    TinglGebyrPantedokument,
    Attestgebyr,
    Transportgebyr,
    AndreGebyrer,
    Boligkjøperforsikring,
    Dokumentavgift,

    InnbetalingHandpenning,
    InnfrielseLån,
    RegleringFastighetsavgift,
    Flyttstädning,
    Annons,
    Besiktning,
    Visningsstädning,
    Styling,
    Övrigt,
    RegleringMånadsavgift,
    UtbetalingHandpenning,

    ProContraKjøperTilSelger,
    ProContraSelgerTilKjøper,

    ProsjektMeglerprovisjon,
    ProsjektOppgjørsgebyr,

    TvangssalgMeglerprovisjon,
    TvangssalgOppgjørsgebyr,

    KonsernMeglerprovisjon,
    KonsernOppgjørsgebyr,

    UtlandMeglerprovisjon,
    UtlandOppgjørsgebyr,

    PurregebyrSelger,
    PurregebyrKjøper,

    StatensKartverkLeverandørReskontroSelger,
    StatensKartverkLeverandørReskontroKjøper,
    StatensKartverkLeverandørReskontroKlient,
    StatensKartverkLeverandørReskontroDrift,

    UtbetalingSelger,
    UtbetalingKjøper
}
