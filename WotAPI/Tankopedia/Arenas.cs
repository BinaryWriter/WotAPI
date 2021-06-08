﻿using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia
{
    public class Arenas : IResponse<Dictionary<string, Arenas.Arena>>
    {
        public partial class Arena
        {
            /// <summary> RU: Идентификатор карты <para> EN: Map ID </para></summary>
            [JsonProperty("arena_id")]
            public string ArenaID;
            /// <summary> RU: Тип карты <para> EN: Map type </para></summary>
            [JsonProperty("camouflage_type")]
            public string CamouflageType;
            /// <summary> RU: Краткое описание карты <para> EN: Short map description </para></summary>
            [JsonProperty("description")]
            public string Description;
            /// <summary> RU: Локализованное название карты <para> EN: Localized map name </para></summary>
            [JsonProperty("name_i18n")]
            public string LocalizatedName;
        }
    }
}
