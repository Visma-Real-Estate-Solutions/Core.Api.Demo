namespace CoreDemo.Models.Enums;

    /// <summary>
    /// Processing basis type
    /// </summary>
    public enum ProcessingBasisType
    {
        /// <summary>
        /// Den registrerte har samtykket til behandling av sine personopplysninger for ett eller flere spesifikke formål.
        /// </summary>
        Consents,

        /// <summary>
        /// Behandlingen er nødvendig for å oppfylle en avtale som den registrerte er part i, eller for å gjennomføre tiltak på den registrertes anmodning før en avtaleinngåelse.
        /// </summary>
        Contracts,

        /// <summary>
        /// Behandlingen er nødvendig for å oppfylle en rettslig forpliktelse som påhviler den behandlingsansvarlige.
        /// </summary>
        LegalObligations,

        /// <summary>
        /// Behandlingen er nødvendig for å verne den registrertes eller en annen fysisk persons vitale interesser.
        /// </summary>
        VitalInterests,

        /// <summary>
        /// Behandlingen er nødvendig for å utføre en oppgave i allmennhetens interesse eller utøve offentlig myndighet som den behandlingsansvarlige er pålagt
        /// </summary>
        PublicInterests,

        /// <summary>
        /// Behandlingen er nødvendig for formål knyttet til de berettigede interessene som forfølges av den behandlingsansvarlige eller en tredjepart, med mindre den registrertes interesser eller grunnleggende rettigheter og friheter går foran og krever vern av personopplysninger, særlig dersom den registrerte er et barn.
        /// </summary>
        InterestsAndRightsSupersedes
    }
